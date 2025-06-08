namespace Tmds.Linux;

public struct group_source_req
{
  public uint             gsr_interface;
  public sockaddr_storage gsr_group;
  public sockaddr_storage gsr_source;
}