namespace Tmds.Linux;

public unsafe struct group_filter
{
  public  uint             gf_interface;
  public  sockaddr_storage gf_group;
  public  uint             gf_fmode;
  public  uint             gf_numsrc;
  private sockaddr_storage _gf_slist;

  public static sockaddr_storage* gf_slist (group_filter* gf)
    => &gf->_gf_slist;
}