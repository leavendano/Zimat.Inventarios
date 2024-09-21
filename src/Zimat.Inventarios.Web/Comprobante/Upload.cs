//using FastEndpoints;
//using MediatR;
//using Zimat.Inventarios.UseCases.Contributors.Create;
//using Zimat.Inventarios.Web.Contributors;

//namespace Zimat.Inventarios.Web.Comprobante;

//public class Upload(IMediator _mediator)  : Endpoint<IFormFile, UploadComprobanteResponse>
//{

//  public override void Configure()
//  {
//    Post("upload/comprobante");
//    AllowAnonymous();
//    Summary(s =>
//    {
//      // XML Docs are used by default but are overridden by these properties:
//      s.Summary = "Crea un comprobante basado en un xml de cfdi.";
//      s.Description = "Carga un cfdi.";
//      //s.ExampleRequest = new CreateContributorRequest { Name = "Contributor Name" };
//    });
//  }

//  public override async Task HandleAsync(IFormFile request, CancellationToken cancellationToken)
//  {
//    var result = await _mediator.Send(new CreateContributorCommand(request), cancellationToken);

//    if (result.IsSuccess)
//    {
//      Response = new CreateContributorResponse(result.Value, request.Name!);
//      return;
//    }
//    // TODO: Handle other cases as necessary
//  }
//}
