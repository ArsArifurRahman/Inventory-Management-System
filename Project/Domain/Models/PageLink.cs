namespace Domain.Models;
public partial class PageLink
{
    public PageLink()
    {
        PageLinkAssign = new HashSet<PageLinkAssign>();
    }

    public int Id { get; set; }
    public int LinkCategoryId { get; set; }
    public virtual PageLinkCategory LinkCategory { get; set; }
    public string RoleId { get; set; }
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Title { get; set; }
    public string IconClass { get; set; }
    public int? Sn { get; set; }
    public virtual ICollection<PageLinkAssign> PageLinkAssign { get; set; }
}
