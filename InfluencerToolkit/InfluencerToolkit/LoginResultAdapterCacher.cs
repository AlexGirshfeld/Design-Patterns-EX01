﻿using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using System.Security.Permissions;
using System.Reflection;
using System.IO;
using FacebookWrapper;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace InfluencerToolkit
{
	public sealed class LogingResultAdapterCacher
	{
		public LoginResultAdapter CurretnLoginResult { get; set; }
		public static readonly string r_CacheFilePath = @"C:\Users\Public\LogingInResultCache.bin";
		public readonly static LogingResultAdapterCacher s_Instance = new LogingResultAdapterCacher();

		private LogingResultAdapterCacher()
		{
		}

		public LoginResultAdapter LoadCachedLoginResultFromDisc()
		{
			LoginResultAdapter retVal = null;
			if (File.Exists(r_CacheFilePath))
			{
				using (Stream stream = new FileStream(r_CacheFilePath, FileMode.Open))
				{
					IFormatter formatter = new BinaryFormatter();
					retVal = (LoginResultAdapter)formatter.Deserialize(stream);
				}
			}
			return retVal;
		}

		public void SaveToFile()
		{
			FileIOPermission fileIOPerm = new FileIOPermission(FileIOPermissionAccess.Write, r_CacheFilePath);
			if (File.Exists(r_CacheFilePath))
			{
				using (Stream stream = new FileStream(r_CacheFilePath, FileMode.Truncate))
				{
					LoginResultAdapter objectToSave;
					if(CurretnLoginResult == null)
					{
						objectToSave = new LoginResultAdapter();
					}
					else
					{
						objectToSave = CurretnLoginResult;
					}
					IFormatter formatter = new BinaryFormatter();
					formatter.Serialize(stream, objectToSave);
				}
			}
			else
			{
				using (Stream stream = new FileStream(r_CacheFilePath, FileMode.CreateNew))
				{
					IFormatter formatter = new BinaryFormatter();
					formatter.Serialize(stream, CurretnLoginResult);
				}
			}
		}
	}

}
