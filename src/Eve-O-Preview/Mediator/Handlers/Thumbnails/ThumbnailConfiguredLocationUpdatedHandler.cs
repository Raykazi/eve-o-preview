using System.Threading;
using System.Threading.Tasks;
using EveOPreview.Mediator.Messages;
using EveOPreview.Mediator.Messages.Thumbnails;
using EveOPreview.Services;
using MediatR;

namespace EveOPreview.Mediator.Handlers.Thumbnails
{
	sealed class ThumbnailConfiguredLocationUpdatedHandler : INotificationHandler<ThumbnailConfiguredLocationUpdated>
	{
		private readonly IThumbnailManager _manager;

		public ThumbnailConfiguredLocationUpdatedHandler(IThumbnailManager manager)
		{
			this._manager = manager;
		}

		public Task Handle(ThumbnailConfiguredLocationUpdated notification, CancellationToken cancellationToken)
		{
			this._manager.UpdateThumbailsLocation();

			return Task.CompletedTask;
		}
	}
}