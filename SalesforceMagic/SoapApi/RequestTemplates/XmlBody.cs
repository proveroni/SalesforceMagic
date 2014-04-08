﻿using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using SalesforceMagic.SoapApi.RequestTemplates;

namespace SalesforceMagic.ORM.BaseRequestTemplates
{
    public partial class XmlBody
    {
        [XmlElement("login", Namespace = SalesforceNamespaces.SalesforceRequest)]
        public LoginRequestTemplate LoginTemplate { get; set; }

        [XmlElement("query", Namespace = SalesforceNamespaces.SalesforceRequest)]
        public QueryTemplate QueryTemplate { get; set; }

        [XmlElement("create", Namespace = SalesforceNamespaces.SalesforceRequest)]
        public CrudTemplate InsertTemplate { get; set; }

        [XmlElement("upsert", Namespace = SalesforceNamespaces.SalesforceRequest)]
        public CrudTemplate UpsertTemplate { get; set; }

        [XmlElement("update", Namespace = SalesforceNamespaces.SalesforceRequest)]
        public CrudTemplate UpdateTemplate { get; set; }

        [XmlElement("delete", Namespace = SalesforceNamespaces.SalesforceRequest)]
        public DeleteTemplate DeleteTemplate { get; set; }
    }
}