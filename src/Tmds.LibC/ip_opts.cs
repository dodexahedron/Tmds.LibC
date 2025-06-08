namespace Tmds.Linux;

public unsafe struct ip_opts
{
  public       in_addr ip_dst;
  public fixed byte    ip_opts_ [40];
}