namespace EveOPreview.Services
{
	public interface IThumbnailManager
	{
		void Start();
		void Stop();

		void UpdateThumbnailsSize();
		void UpdateThumbnailFrames();
		void UpdateThumbailsLocation();
	}
}