﻿/*
 * Created by SharpDevelop.
 * User: KuanyshMadina
 * Date: 03.05.2018
 * Time: 21:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace ArmyRep
{
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public class Settings
	{
		//private AppSettingsSection _appSettings;
    	//private NumberFormatInfo _nfi;
	
    	public Settings()
    	{}
		/*
    	public Settings(Assembly currentAssembly)
	    {
	        UriBuilder uri = new UriBuilder(currentAssembly.CodeBase);
	        string configPath = Uri.UnescapeDataString(uri.Path);
	        Configuration myDllConfig = ConfigurationManager.OpenExeConfiguration(configPath);
	        _appSettings = myDllConfig.AppSettings;
	        _nfi = new NumberFormatInfo() 
	        { 
	            NumberGroupSeparator = "", 
	            CurrencyDecimalSeparator = "." 
	        };
	    }
	
	
	    public T Setting<T>(string name)
	    {
	        try
	        {
	            return (T)Convert.ChangeType(_appSettings.Settings[name].Value, typeof(T), _nfi);
	        }
	        catch (Exception ex)
	        {
	            return default(T);
	        }
	    }
	    */
	}
}
