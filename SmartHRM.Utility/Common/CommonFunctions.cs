using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;

namespace PIMS.Web.Common
{
	public static class CommonFunctions
	{
		public static byte[] ReduceImage(byte[] bytes)
		{
			using var memoryStream = new MemoryStream(bytes);
			using var image = Image.Load(memoryStream);
			image.Mutate(x => x.Resize(300,208));
			using var outputStream = new MemoryStream();
			image.Save(outputStream, new PngEncoder() /*or another encoder*/);
			return outputStream.ToArray();
		}
	}
}
