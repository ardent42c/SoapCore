using System;
using System.Reflection;
using System.Xml.Serialization;

namespace SoapCore.Meta
{
	public class TypeToBuild
	{
		public TypeToBuild(Type type)
		{
			Type = type;
			TypeName = type.GetSerializedTypeName();
			ChildElementName = null;
			IsAnonumous = type.GetCustomAttribute<XmlTypeAttribute>()?.AnonymousType == true;
		}

		public bool IsAnonumous { get; }

		// ALON: Added set to Type, since it changes when using XmlArray and XmlItem.
		public Type Type { get; set; }
		public string TypeName { get; set; }
		public string ChildElementName { get; set; }

		// ALON: Added ChildType for XmlArray support.
		public Type ChildType { get; set; }
	}
}
