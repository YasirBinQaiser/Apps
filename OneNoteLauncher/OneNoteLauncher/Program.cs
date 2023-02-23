using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;

using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

using Microsoft.Office.Interop.OneNote;


namespace OneNoteLauncher
{
static class Program
{
static void Main(string[] args)
    {
    string strs = "";
    foreach (string str in args)
        strs = strs + " " + str;
    
    strs = strs.Trim(); 
    LaunchOneNote (strs);
    }

static string GetOneNoteRoot()
    {
    string rootFolder = "";

    string registry_key = @"SOFTWARE\Microsoft\Office\";
    using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
        {
        foreach (string subkey_name in key.GetSubKeyNames())
            {
            double val = 0.0;
            if (!double.TryParse(subkey_name, out val))
                continue;

            RegistryKey subkey = Registry.LocalMachine.OpenSubKey(registry_key + subkey_name + "\\onenote\\installroot\\");
            if (subkey == null)
                continue;

            rootFolder = subkey.GetValue ("Path") as string;
            break;

            }
        }


    return rootFolder;
    }




static void LaunchOneNote(string filter)
    {
    Microsoft.Office.Interop.OneNote.Application oneNoteApp = new Microsoft.Office.Interop.OneNote.Application();
            
    string noteBookXML;
    oneNoteApp.GetHierarchy(null, HierarchyScope.hsNotebooks, out noteBookXML);
    XDocument xDocument = XDocument.Parse(noteBookXML);
    XNamespace ns = xDocument.Root.Name.Namespace;
 
    int iterator = 0;
    foreach (XElement item in from node in xDocument.Descendants(ns + "Notebook") select (node))
        {
        string id = item.Attribute("ID").Value;
        try
            {
            string searchResult = "";
            ((IApplication)oneNoteApp).FindPages(id, filter, out searchResult);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Notebook));
            TextReader reader = new StringReader(searchResult);
            Notebook notebook = xmlSerializer.Deserialize(reader) as Notebook;
            if (notebook.Section != null && notebook.Section.Page != null)
                {
                string oneNotePath = GetOneNoteRoot() + "OneNote.exe" ;

                if (string.IsNullOrEmpty(oneNotePath))
                    return;

                Process exeProcess = new Process();
                exeProcess.StartInfo.FileName = oneNotePath;
                exeProcess.StartInfo.UseShellExecute = false;
                string oneNoteURL = "onenote:///\"" + notebook.Section.path +
                                                    "\"#\"" + notebook.Section.Page.name +
                                                    "\"&section-id=" + notebook.Section.ID +
                                                    "&page-id=" + notebook.Section.Page.ID +
                                                    "&end";

                exeProcess.StartInfo.Arguments = "/hyperlink " + oneNoteURL;
                exeProcess.Start();


                //oneNoteApp.NavigateTo (notebook.Section.ID, notebook.Section.Page.ID);
                return;
                }
            }
        catch (Exception ex)
            {
            Console.WriteLine(ex.Message);
            }
        iterator++;
        }

    }
}
}
