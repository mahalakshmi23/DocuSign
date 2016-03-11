/*
 * Created by SharpDevelop.
 * User: Mahalakshmi
 * Date: 3/10/2016
 * Time: 6:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

namespace DocuSignCodingChallenge
{
	/// <summary>
	/// Description of DataAccessLayer.
	/// This Class is used to access the HOT,COLD and ClimateType classes.
	/// This Class provides abstraction as we hide the actual implementation but only
	/// show the essential details about how the input is processed.
	/// </summary>
	/// 
	public class DataAccessLayer
	{
		
		public static String evaluate(String input) {
			
			input=input.Replace(",",string.Empty);
			String[] inputArray=input.Split(' ');		
			StringBuilder output=new StringBuilder();
		
			//Creating an object of type "HOT" or "COLD"
			ClimateType obj=createInstance(inputArray[0]);
			
			if(obj==null)
				return "fail";
			
			//After object creation , the first step is removing PJ's.
			if(!inputArray[1].Equals("8"))
				return "fail";
			else
				output.Append(obj.removePjs());
			
			
			//All the other inputs are evaluated in the order they are received.
			
			for(int i=2;i<inputArray.Length;i++) {
				
				String result="";
				
				switch(inputArray[i]) {
						
					case "1":{						
							result=obj.footwear();
							break;						   
					}
					
					case "2":{							
							result=obj.headwear();
							break;
					}
				
					case "3" :{
							result=obj.socks();						   
							break;
					}
				
					case "4" :{
							result=obj.shirt();
							break;
					}
				
					case "5": {
							result=obj.jacket();
							break;
					}
				
					case "6" :{
							
							result=obj.pants();
							break;
					}
				
					case "7" :{
							result=obj.leaveHouse();
							break;
					}
						
						
					default:{
						result="fail";
						break;
					}
				}
				
				
				output.Append(result);
				
				if(result.Equals("fail")){
					obj.reset();
					return output.ToString();
				}
						
			}
			
			obj.reset();		
			return output.ToString();
		}

		
		
		/*This method creates an object for the Climate type based on the input.
		 * Based on the input parameter type,HOT or COLD,
		 * the corresponding object is created.
		 * */
		
		public static ClimateType createInstance(String type){
			
			if(type.ToLower().Equals("hot"))
				return new HOT();
			else if(type.ToLower().Equals("cold"))
				return new COLD();
			else
				return null;
		}
		
	}
}
