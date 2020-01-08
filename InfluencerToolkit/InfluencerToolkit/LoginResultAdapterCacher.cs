using System;
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
		public static readonly string r_CacheFilePath = @"C:\Users\Public\LogingInResultCache.bin";
		private bool m_ThereIsCachedLoginResultOnDisc;
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
					//XmlSerializer serializer = new XmlSerializer(retVal.GetType());
					//retVal = serializer.Deserialize(stream) as User;
					//retVal = formatter.Deserialize(stream) as LoginResult;
				}
			}
			return retVal;
		}

		public void SaveToFile(LoginResultAdapter i_LoginResultToStore)
		{
			FileIOPermission fileIOPerm = new FileIOPermission(FileIOPermissionAccess.Write, r_CacheFilePath);
			if (File.Exists(r_CacheFilePath))
			{

				using (Stream stream = new FileStream(r_CacheFilePath, FileMode.Truncate))
				{
					IFormatter formatter = new BinaryFormatter();
					//XmlSerializer serializer = new XmlSerializer(i_LoginResultToStore.GetType());
					//XmlSerializer serializer = CreateOverrider();
					//serializer.Serialize(stream, i_LoginResultToStore);
					formatter.Serialize(stream, i_LoginResultToStore);
				}
			}
			else
			{
				using (Stream stream = new FileStream(r_CacheFilePath, FileMode.CreateNew))
				{
					IFormatter formatter = new BinaryFormatter();
					//XmlSerializer serializer = new XmlSerializer(i_LoginResultToStore.GetType());
					//XmlSerializer serializer = CreateOverrider();
					//serializer.Serialize(stream, i_LoginResultToStore);
					formatter.Serialize(stream, i_LoginResultToStore);
				}
			}
		}
		public XmlSerializer CreateOverriderReg()
		{
			// Create the XmlAttributeOverrides and XmlAttributes objects.
			XmlAttributeOverrides xOver = new XmlAttributeOverrides();
			XmlAttributes attrs = new XmlAttributes();

			/* Setting XmlIgnore to false overrides the XmlIgnoreAttribute
			   applied to the Comment field. Thus it will be serialized.*/
			attrs.XmlIgnore = true;
			User u = new User();
			xOver.Add(u.GetType(), "Pictures", attrs);
			xOver.Add(typeof(OwnerObject), "Pictures", attrs);
			xOver.Add(typeof(OwnerObject), "Events", attrs);
			xOver.Add(typeof(OwnerObject), "Albums", attrs);
			xOver.Add(typeof(User), "Albums", attrs);
			xOver.Add(typeof(User), "EventsDeclined", attrs);
			xOver.Add(typeof(User), "EventsMaybe", attrs);
			xOver.Add(typeof(User), "EventsNotYetReplied", attrs);
			xOver.Add(typeof(User), "EventsCreated", attrs);
			xOver.Add(typeof(User), "LikedPages", attrs);
			xOver.Add(typeof(User), "DynamicWrapper", attrs);
			xOver.Add(typeof(DynamicWrapper), "", attrs);
			xOver.Add(typeof(Photo), "Pictures", attrs);
			//xOver.Add(typeof(OwnerObject), "Pictures", attrs);
			xOver.Add(u.GetType(), "Name", attrs);
			xOver.Add(typeof(LoginResult), "AccessToken", attrs);

			/* Use the XmlIgnore to instruct the XmlSerializer to ignore
			   the GroupName instead. */
			attrs = new XmlAttributes();
			attrs.XmlIgnore = true;
			
			xOver.Add(typeof(User), "Friends", attrs);
			xOver.Add(typeof(User), "Names", attrs);
			XmlSerializer xSer = new XmlSerializer(typeof(User), xOver);
			return xSer;
		}

		public XmlSerializer CreateOverrider()
		{
			// Create the XmlAttributeOverrides and XmlAttributes objects.
			XmlAttributeOverrides xOver = new XmlAttributeOverrides();
			XmlAttributes attrs = new XmlAttributes();

			/* Setting XmlIgnore to false overrides the XmlIgnoreAttribute
			   applied to the Comment field. Thus it will be serialized.*/
			attrs.XmlIgnore = true;
			User u = new User();
			xOver.Add(u.GetType(), "Pictures", attrs);
			xOver.Add(typeof(PostAdapter), "m_Post", attrs);
			//xOver.Add(typeof(OwnerObject), "Pictures", attrs);
			xOver.Add(u.GetType(), "Name", attrs);
			xOver.Add(typeof(LoginResult), "AccessToken", attrs);

			/* Use the XmlIgnore to instruct the XmlSerializer to ignore
			   the GroupName instead. */
			attrs = new XmlAttributes();
			attrs.XmlIgnore = true;

			xOver.Add(typeof(User), "Friends", attrs);
			xOver.Add(typeof(User), "Names", attrs);
			XmlSerializer xSer = new XmlSerializer(typeof(LoginResultAdapter), xOver);
			return xSer;
		}

	}

}
