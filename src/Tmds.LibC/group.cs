namespace Tmds.Linux;

[SuppressMessage ("ReSharper", "InconsistentNaming")]
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
public unsafe struct group
{
  public byte*  gr_name;
  public byte*  gr_passwd;
  public gid_t  gr_gid;
  public byte** gr_mem;
}
