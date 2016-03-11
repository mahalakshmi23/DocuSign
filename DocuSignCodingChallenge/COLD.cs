/*
 * Created by SharpDevelop.
 * User: Mahalakshmi
 * Date: 3/3/2016
 * Time: 11:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DocuSignCodingChallenge
{
	/// <summary>
	/// Description of COLD class. This Class inherits from the
	/// parent class ClimateType.
	/// </summary>
	public class COLD : ClimateType
	{
		public COLD()
		{
			
		}
		
		
		public override String footwear() {
			
			if(isSocks && isPants && !isFootwear) {
				isFootwear=true;
				return "boots, ";	
			}
			else{
				return "fail";
			}
		}
		
		
		public override String headwear(){
			
			if(isShirt && !isHeadwear) {
				isHeadwear=true;
				return "hat, ";
			}
			else{
				return "fail";
			}
		}
		
		
		
		public override String socks(){			
			
			if(!isSocks) {
				isSocks=true;
				return "socks, ";
			}
			else{
				return "fail";
			}			
			
		}
		
		
		
		public override String shirt(){
			
			if(!isShirt){
				isShirt=true;
				return "shirt, ";
			}
			else{
				return "fail";
			}		
		}
		
		
		
		
		public override String jacket(){
			
			if(isShirt && !isJacket) {						
				isJacket=true;
				return "jacket, ";				
			}
			else{
				return "fail";
			}			
		}
		
		
		
		public override String pants(){			
			
			if(!isPants){
				isPants=true;
				return "pants, ";
			}
			else{
				return "fail";
			}		
		}
	}
}
