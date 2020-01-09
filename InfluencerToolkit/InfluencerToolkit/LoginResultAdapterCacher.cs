using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;

namespace InfluencerToolkit
{
	public sealed class LogingResultAdapterCacher
	{
		public LoginResultAdapter CurretnLoginResult { get; set; }

		private static readonly string r_CacheFilePath = @"C:\Users\Public\LogingInResultCache.bin";

		public static readonly LogingResultAdapterCacher s_Instance = new LogingResultAdapterCacher();

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
