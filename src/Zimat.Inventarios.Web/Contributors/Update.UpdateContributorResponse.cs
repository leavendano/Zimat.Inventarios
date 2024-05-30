namespace Zimat.Inventarios.Web.Contributors;

public class UpdateContributorResponse(ContributorRecord contributor)
{
  public ContributorRecord Contributor { get; set; } = contributor;
}
