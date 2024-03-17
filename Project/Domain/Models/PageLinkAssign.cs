namespace Domain.Models;
public partial class PageLinkAssign
{
    public int Id { get; set; }
    public int RegistrationId { get; set; }
    public virtual Registration Registration { get; set; }
    public int LinkId { get; set; }
    public virtual PageLink Link { get; set; }
}
