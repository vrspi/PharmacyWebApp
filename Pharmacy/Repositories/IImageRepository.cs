using System.Drawing;

namespace Pharmacy.Repositories
{
	public interface IImageRepository
	{
		
		Image? GetImage(int Id);
		bool AddImage(Models.Image image);
		bool DeleteImage(int Id);
		bool UpdateImage(Image imageEdited);
	}
}
