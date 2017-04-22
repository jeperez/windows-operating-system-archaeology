var a = new ActiveXObject("System.EnterpriseServices.RegistrationHelper");
try
{
	a.InstallAssembly("example.dll", null, null, 0 );
}
catch (e)
{
	
}
