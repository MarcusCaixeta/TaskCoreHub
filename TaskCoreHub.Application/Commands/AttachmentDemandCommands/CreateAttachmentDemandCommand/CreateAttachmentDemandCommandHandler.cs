using Amazon.S3;
using Amazon.S3.Transfer;
using Amazon.SQS;
using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Commands.AttachmentDemandCommands.CreateAttachmentDemandCommand
{

    public class CreateAttachmentDemandCommandHandler : IRequestHandler<CreateAttachmentDemandCommand, ResponseResult<Guid>>
    {
        private readonly IAttachmentDemandRepository _repository;
        private readonly IAmazonS3 _s3Client;
        private readonly string _bucketName = "marcusaixetaarvalhoteste10";


        public CreateAttachmentDemandCommandHandler(IAttachmentDemandRepository repository, IAmazonS3 s3Client)
        {
            _repository = repository;
            _s3Client = s3Client;
        }

        public async Task<ResponseResult<Guid>> Handle(CreateAttachmentDemandCommand request, CancellationToken cancellationToken)
        {
            var arquivo = request.Arquivo;

            if (arquivo == null || arquivo.Length == 0)
                throw new ArgumentException("Arquivo inválido");

            var key = Guid.NewGuid() + Path.GetExtension(arquivo.FileName);

            using var stream = arquivo.OpenReadStream();
            var uploadRequest = new TransferUtilityUploadRequest
            {
                InputStream = stream,
                Key = key,
                BucketName = _bucketName,
                ContentType = arquivo.ContentType
            };
            var fileTransferUtility = new TransferUtility(_s3Client);
            await fileTransferUtility.UploadAsync(uploadRequest, cancellationToken);

            var createAttachmentDemand = new AttachmentDemand(request.IdDemand, request.Description, key);

            await _repository.Create(createAttachmentDemand);
            return new ResponseResult<Guid>(createAttachmentDemand.Id);
        }
    }
}
