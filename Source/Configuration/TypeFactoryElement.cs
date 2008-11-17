using System;
using System.Configuration;
using BLToolkit.TypeBuilder;

namespace BLToolkit.Configuration
{
	internal class TypeFactoryElement : ElementBase
	{
		protected static readonly ConfigurationProperty _propSaveTypes =
			new ConfigurationProperty("saveTypes",    typeof(bool),    false,        ConfigurationPropertyOptions.None);
		protected static readonly ConfigurationProperty _propSealTypes =
			new ConfigurationProperty("sealTypes",    typeof(bool),    true,         ConfigurationPropertyOptions.None);
		protected static readonly ConfigurationProperty _propAssemblyPath =
			new ConfigurationProperty("assemblyPath", typeof(string),  null,         ConfigurationPropertyOptions.None);
		protected static readonly ConfigurationProperty _propVersion =
			new ConfigurationProperty("version",      typeof(string),  null,         ConfigurationPropertyOptions.None);
		protected static readonly ConfigurationProperty _propKeyFile =
			new ConfigurationProperty("keyFile",      typeof(string),  null,         ConfigurationPropertyOptions.None);

		public TypeFactoryElement()
		{
			_properties.Add(_propSaveTypes);
			_properties.Add(_propSealTypes);
			_properties.Add(_propAssemblyPath);
			_properties.Add(_propVersion);
			_properties.Add(_propKeyFile);
		}

		/// <summary>
		/// Gets a value indicating whether the <see cref="TypeFactory"/>
		/// will save generated assemblies to the disk. Default is <see langword="false"/>.
		/// </summary>
		public bool SaveTypes
		{
			get { return (bool) base[_propSaveTypes]; }
		}

		/// <summary>
		/// Gets a value indicating whether the <see cref="TypeFactory"/>
		/// will seal generated types. Default is <see langword="true"/>.
		/// </summary>
		public bool SealTypes
		{
			get { return (bool) base[_propSealTypes]; }
		}

		/// <summary>
		/// Gets a path to the global assembly. Default is <see langword="null"/>.
		/// </summary>
		/// <seealso cref="TypeFactory.SetGlobalAssembly(string)"/>
		public string AssemblyPath
		{
			get { return (string) base[_propAssemblyPath]; }
		}

		/// <summary>
		/// Gets the version of global assembly. Default is <see langword="null"/>.
		/// </summary>
		/// <seealso cref="TypeFactory.SetGlobalAssembly(string,System.Version,string)"/>
		public Version Version
		{
			get
			{
				string strVersion = (string)base[_propVersion];

				return string.IsNullOrEmpty(strVersion)? null:
					new Version(strVersion);
			}
		}

		/// <summary>
		/// Gets a path to the key file to sign global assembly. Default is <see langword="null"/>.
		/// </summary>
		/// <seealso cref="TypeFactory.SetGlobalAssembly(string,System.Version,string)"/>
		public string KeyFile
		{
			get { return (string) base[_propKeyFile]; }
		}
	}
}