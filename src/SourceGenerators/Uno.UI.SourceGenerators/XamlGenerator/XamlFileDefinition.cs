﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Uno.UI.SourceGenerators.Helpers;
using Uno.UI.SourceGenerators.XamlGenerator.XamlRedirection;

namespace Uno.UI.SourceGenerators.XamlGenerator
{
    internal class XamlFileDefinition
	{
		public XamlFileDefinition(string file)
		{
			Namespaces = new List<NamespaceDeclaration>();
			Objects = new List<XamlObjectDefinition>();
			FilePath = file;

			UniqueID = SanitizedFileName + "_" + HashBuilder.Build(FilePath);
		}

		private string SanitizedFileName => Path
			.GetFileNameWithoutExtension(FilePath)
			.Replace(" ", "_")
			.Replace(".", "_");

		public List<NamespaceDeclaration> Namespaces { get; private set; }
		public List<XamlObjectDefinition> Objects { get; private set; }

		public string FilePath { get; private set; }

		public string UniqueID { get; }
	}
}