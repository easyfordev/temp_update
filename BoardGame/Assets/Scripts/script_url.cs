using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_url : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void restaurant1_url(int site)
    {
        if (site == 0)
            Application.OpenURL("https://search.naver.com/search.naver?where=post&sm=tab_jum&query=%ED%86%B5%ED%86%B5%EB%8F%BC%EC%A7%80");
        else if (site == 1)
            Application.OpenURL("https://www.instagram.com/explore/tags/%ED%86%B5%ED%86%B5%EB%8F%BC%EC%A7%80/");
        else if (site == 2)
            Application.OpenURL("https://www.google.com/search?newwindow=1&source=hp&ei=NnOjW_T0Mond8QXU1ZDgBA&q=%ED%86%B5%ED%86%B5%EB%8F%BC%EC%A7%80&oq=%ED%86%B5%ED%86%B5%EB%8F%BC%EC%A7%80&gs_l=psy-ab.3...4109.6975.0.7228.19.14.2.0.0.0.303.1926.0j4j4j1.9.0....0...1c.1j4.64.psy-ab..12.7.1234.0..0j0i7i30k1.0.HaIrvclRufI");
    }
    public void bar1_url(int site)
    {
        if (site == 0)
            Application.OpenURL("https://search.naver.com/search.naver?where=post&sm=tab_jum&query=%EC%8B%AC%EC%95%BC%EC%9D%98+%EB%AF%B8%EC%8B%9D%EA%B0%80");
        else if (site == 1)
            Application.OpenURL("https://www.instagram.com/explore/tags/%EC%8B%AC%EC%95%BC%EC%9D%98%EB%AF%B8%EC%8B%9D%EA%B0%80/");
        else if (site == 2)
            Application.OpenURL("https://www.google.com/search?newwindow=1&ei=QHOjW80CivzxBc3Rp4AC&q=%EC%8B%AC%EC%95%BC%EC%9D%98%EB%AF%B8%EC%8B%9D%EA%B0%80&oq=%EC%8B%AC%EC%95%BC%EC%9D%98%EB%AF%B8%EC%8B%9D%EA%B0%80&gs_l=psy-ab.3..0i5i30k1l2.89672.91538.0.91756.15.11.0.0.0.0.301.1459.0j4j2j1.7.0....0...1c.1j4.64.psy-ab..13.2.591...0.0.s7hvsi-yDCM");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
