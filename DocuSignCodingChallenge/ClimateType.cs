/*
 * Created by SharpDevelop.
 * User: Mahalakshmi
 * Date: 3/3/2016
 * Time: 7:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DocuSignCodingChallenge
{
	/// <summary>
	/// Description of ClimateType.This class provides various methods 
	/// that are associated with dressing up. These methods are appropriately
	/// overridden in its child classes based on the climate type.
	/// </summary>
	public class ClimateType
	{
		
		public static Boolean isFootwear=false;
		public static Boolean isHeadwear=false;
		public static Boolean isSocks=false;
		public static Boolean isShirt=false;
		public static Boolean isJacket=false;
		public static Boolean isPants=false;
		
		public ClimateType()
		{
		}
		
		public virtual String footwear(){
			return "";
		}		
		public virtual String headwear(){
			return "";
		}
		public virtual String socks(){
			return "";
		}
		public virtual String shirt(){
			return "";
		}
		public virtual String jacket(){
			return "";
		}
		public virtual String pants(){
			return "";
		}
		
		public virtual String removePjs(){
			return "Removing PJs, ";
		}
		
		
		//This method is not declared virtual as it should not be overridden.
		public String leaveHouse(){
			if(isFootwear && isHeadwear && isSocks && isShirt && isJacket && isPants){
				return "leaving house";
			}
			else{
				return "fail";
			}
		}
		
		//This method is not declared virtual as it should not be overridden.
		
		public void reset(){
			isFootwear=false;
			isHeadwear=false;
			isSocks=false;
			isShirt=false;
			isJacket=false;
			isPants=false;
		}
	}
}
