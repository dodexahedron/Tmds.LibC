namespace Tmds.Linux;

public struct group_req
{
  public uint             gr_interface;
  public sockaddr_storage gr_group;
}