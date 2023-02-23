
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote", IsNullable = false)]
public partial class Notebook
{

    private NotebookSection sectionField;

    private string nameField;

    private string nicknameField;

    private string idField;

    private string pathField;

    private System.DateTime lastModifiedTimeField;

    private string colorField;

    private bool isCurrentlyViewedField;

    /// <remarks/>
    public NotebookSection Section
    {
        get
        {
            return this.sectionField;
        }
        set
        {
            this.sectionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nickname
    {
        get
        {
            return this.nicknameField;
        }
        set
        {
            this.nicknameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string path
    {
        get
        {
            return this.pathField;
        }
        set
        {
            this.pathField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime lastModifiedTime
    {
        get
        {
            return this.lastModifiedTimeField;
        }
        set
        {
            this.lastModifiedTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isCurrentlyViewed
    {
        get
        {
            return this.isCurrentlyViewedField;
        }
        set
        {
            this.isCurrentlyViewedField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
public partial class NotebookSection
{

    private NotebookSectionPage pageField;

    private string nameField;

    private string idField;

    private string pathField;

    private System.DateTime lastModifiedTimeField;

    private string colorField;

    private bool isCurrentlyViewedField;

    /// <remarks/>
    public NotebookSectionPage Page
    {
        get
        {
            return this.pageField;
        }
        set
        {
            this.pageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string path
    {
        get
        {
            return this.pathField;
        }
        set
        {
            this.pathField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime lastModifiedTime
    {
        get
        {
            return this.lastModifiedTimeField;
        }
        set
        {
            this.lastModifiedTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isCurrentlyViewed
    {
        get
        {
            return this.isCurrentlyViewedField;
        }
        set
        {
            this.isCurrentlyViewedField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/office/onenote/2013/onenote")]
public partial class NotebookSectionPage
{

    private string idField;

    private string nameField;

    private System.DateTime dateTimeField;

    private System.DateTime lastModifiedTimeField;

    private byte pageLevelField;

    private bool isCurrentlyViewedField;

    private string selectedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime dateTime
    {
        get
        {
            return this.dateTimeField;
        }
        set
        {
            this.dateTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime lastModifiedTime
    {
        get
        {
            return this.lastModifiedTimeField;
        }
        set
        {
            this.lastModifiedTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte pageLevel
    {
        get
        {
            return this.pageLevelField;
        }
        set
        {
            this.pageLevelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isCurrentlyViewed
    {
        get
        {
            return this.isCurrentlyViewedField;
        }
        set
        {
            this.isCurrentlyViewedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string selected
    {
        get
        {
            return this.selectedField;
        }
        set
        {
            this.selectedField = value;
        }
    }
}

