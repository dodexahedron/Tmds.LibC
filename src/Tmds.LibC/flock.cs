namespace Tmds.Linux;

public struct flock
{
  public short l_type;
  public short l_whence;
  public off_t l_start;
  public off_t l_len;
  public pid_t l_pid;
}
