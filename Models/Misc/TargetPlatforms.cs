namespace YYModels.Models;

[Flags]
public enum TargetPlatforms : long
{
  MacOSX = 2,
  IOS = 4,
  Android = 8,
  HTML5 = 32,
  Windows = 64,
  Ubuntu = 128,
  WindowsPhone = 4096,
  SteamWorkshop = 16384,
  Windows8JavaScript = 32768,
  SmartwatchJS = 65536,
  WindowsYYC = 1048576,
  AndroidYYC = 2097152,
  Windows8 = 4194304,
  Smartwatch = 8388608,
  SmartwatchYYC = 16777216,
  IOSYYC = 33554432,
  MacOSXYYC = 67108864,
  UbuntuYYC = 134217728,
  WindowsPhoneYYC = 268435456,
  Windows8YYC = 536870912,
  Vita = 2147483648,
  PS4 = 4294967296,
  VitaYYC = 68719476736,
  PS4YYC = 137438953472,
  PS3 = 2199023255552,
  PS3YYC = 4398046511104,
  GMPlayer = 17592186044416,
  AndroidTV = 140737488355328,
  AndroidTVYYC = 281474976710656,
  AmazonFire = 562949953421312,
  AmazonFireYYC = 1125899906842624,
  TVOS = 9007199254740992,
  TVOSYYC = 18014398509481984,
  Switch = 144115188075855872,
  SwitchYYC = 288230376151711744,
  PS5 = 576460752303423488,
  PS5YYC = 1152921504606846976,
  XboxSeries = 2305843009213693952,
  XboxSeriesYYC = 4611686018427387904,
  WebAssembly = -9223372036854775808,
  OperaGX = 17179869184,
  LegacyPlatforms = 
      SwitchYYC | Switch | 
      TVOSYYC | TVOS | 
      AmazonFireYYC | AmazonFire | 
      AndroidTVYYC | AndroidTV | 
      GMPlayer | 
      PS3YYC | PS3 | 
      PS4YYC | PS4 | 
      VitaYYC | Vita | 
      Windows8YYC | WindowsPhoneYYC | UbuntuYYC | MacOSXYYC | IOSYYC |
      Windows8 | WindowsPhone | Ubuntu | MacOSX | IOS | 
      AndroidYYC | WindowsYYC | 
      Windows8JavaScript | 
      SteamWorkshop | 
      Windows | HTML5 | Android | IOS | MacOSX,
  All = -1,
}