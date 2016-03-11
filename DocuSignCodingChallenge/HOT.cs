/*
 * Created by SharpDevelop.
 * User: Mahalakshmi
 * Date: 3/3/2016
 * Time: 11:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DocuSignCodingChallenge
{
	/// <summary>
	/// Description of HOT class. This Class inherits from the
	/// parent class ClimateType.
	/// </summary>
	public class HOT : ClimateType
	{
		
		public HOT()
		{
			isSocks=true;
			isJacket=true;
			
		}
		
		
		public override String footwear(){
			
			if(isSocks && isPants && !isFootwear) {
				isFootwear=true;
				return "sandals, ";	
			}
			else{
				return "fail";
			}				
		}	

		
		public override String headwear(){
			
			if(isShirt && !isHeadwear){
				isHeadwear=true;
				return "sun visor, ";
			}
			else{
				return "fail";
			}		
		}
		
			
		public override String socks(){
			return "fail, ";
		}
		
		
		public override String shirt(){
						
			if(!isShirt){
				isShirt=true;
				return "t-shirt, ";
			}
			else{
				return "fail";
			}
		}
		
		
		
		public override String jacket(){
			return "fail, ";
		}
		
		
		
		public override String pants(){
			
			if(!isPants){
				isPants=true;
				return "shorts, ";
			}
			else{
				return "fail";
			}
		}
		
	}
}
