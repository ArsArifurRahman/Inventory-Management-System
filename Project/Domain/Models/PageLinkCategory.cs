﻿namespace Domain.Models;
public partial class PageLinkCategory
{
    public PageLinkCategory()
    {
        PageLink = new HashSet<PageLink>();
    }

    public int Id { get; set; }
    public string Category { get; set; }
    public string IconClass { get; set; }
    public int? Sn { get; set; }
    public virtual ICollection<PageLink> PageLink { get; set; }
}
