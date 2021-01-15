using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

public void print(){
	print("clicked");
}
	public void OpenPortfolio()
	{
		#if !UNITY_EDITOR
		openWindow("https://harsukhdeol.github.io/web-graphics-portfolio/");
		#endif
	}
	public void OpenResume()
	{
		#if !UNITY_EDITOR
		openWindow("https://harsukhdeol.github.io/portfolio/assets/HarsukhDeol.pdf");
		#endif
	}
	public void OpenWebsite()
	{
		#if !UNITY_EDITOR
		openWindow("https://harsukhdeol.github.io/portfolio/");
		#endif
	}
	public void OpenGithub()
	{
		#if !UNITY_EDITOR
		openWindow("https://github.com/harsukhdeol");
		#endif
	}
	public void OpenIg()
	{
		#if !UNITY_EDITOR
		openWindow("https://www.instagram.com/harsukh.deol/");
		#endif
	}
	public void OpenSnap()
	{
		#if !UNITY_EDITOR
		openWindow("https://lensstudio.snapchat.com/creator/Y9vZ5BLdpADhDDu9NFqWcA");
		#endif
	}
	public void OpenEmail()
	{
		#if !UNITY_EDITOR
		openWindow("mailto:harsukhkdeol@gmail.com");
		#endif
	}
	public void OpenLinkd()
	{
		#if !UNITY_EDITOR
		openWindow("https://www.linkedin.com/in/harsukh-deol-861920177/");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}