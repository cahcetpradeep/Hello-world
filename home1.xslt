<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
	<head>
	<style>
		table {
			width:100%;
			table-layout:fixed;
			border-collapse:collapse;
		}
	
		.labb {
			font-size : 13px;
			font-weight : bold;
		
		}
		.vals {
			font-size : 19px;
			font-size : 19px;
		}
	</Style>
</head>
<body>
	<table border="1">
		<tr style="height:40px">
			<td colspan="40">
				 <span class="labb">CLIENT : </span>
				 <span class="vals"><xsl:value-of select="demo/cli"/></span>
			</td>
			<td colspan="30">
				 <span class="labb">SERVICE REPORT NO  :  </span></td>
				 <span class="vals"><xsl:value-of select="demo/ser_no"/></span>
			<td colspan="30" rowspan="5">
				<center>
					<span>ANY OTHER</span>
				</center>
			</td>
		</tr>
		<tr style="height:30px">
			<td colspan="26">
				 <span style = "padding-left: 10px">PLACE:</span>
				 <span class="vals"><xsl:value-of select="demo/p"/></span>
			 </td>
			<td colspan="14" rowspan="2">
				 <table>
					<tr style="height: 20px">
						<td colspan = "100">
							<span class="labb">PERSONS CONTRACTED</span>
						</td>	
					  </tr>
					<tr style="height: 20px">
						<td colspan = "100">
							<span class="labb">MR.</span>
						    <span class="vals"><xsl:value-of select="demo/per_mr1"/></span>
						</td>	
					  </tr>
					<tr style="height: 20px">
						<td colspan = "100">
							<span class="labb">MR.</span>
							<span class="vals"><xsl:value-of select="demo/per_mr2"/></span>
						</td>	
					  </tr>
				 </table>
			 </td>
			 <td colspan="15">
				 <span class="labb">UNIT SR. NO</span>
			 </td>
			<td colspan="15">
				<span class="vals"><xsl:value-of select="demo/usrno"/></span>
			 </td>
		</tr>
		<tr style="height:30px">
			<td colspan="10">
				<span class="labb">TSF MR</span>
			</td>
			<td colspan="16">
				<span class="vals"><xsl:value-of select="demo/tsf"/></span>
			</td>
			<td colspan="15">
				<span class="labb">TSF CODE</span>
			</td>
			<td colspan="15">
				<span class="vals"><xsl:value-of select="demo/tsf_code"/></span>
			</td>
		</tr>	
		
		<tr style="height:30px">
			<td colspan="10">
				<span>TYPE OF CALL</span>
			</td>
			<td colspan="20">
				<span>ASC</span>
			</td>
			<td colspan="10">
				<span>OVER HAULING</span>
			</td>
			
			<td colspan="15">
				<span>SERVICE</span>
			</td>
			
			<td colspan="15">
				<span>SPARTS</span>
			</td>
		</tr>	
			
		
		<tr style="height:30px">
			<td colspan="10">
				<span></span>
			</td>
			<td colspan="10">
				<span>OIT</span>
			</td>
			<td colspan="10">
				<span>OVER HAULING</span>
			</td>
			<td colspan="10">
				<span>B/D</span>
			</td>
			
			
			<td colspan="15">
				<span>BREAK DOWN</span>
			</td>
			
			<td colspan="15">
				<span>ERACTION COMMISIONING</span>
			</td>
		</tr>
        
                <tr>			  
			<td colspan="100" height="250"></td>
		</tr>	
		<tr>
			<td colspan="70">
				<span>ACTION REQUIRED BY CLIENT</span>
			</td>
			<td colspan="15">
				<span>TEST RESULT</span>		  
			</td>
			<td colspan="5">
				<span>OK</span>		  
			</td>
			<td colspan="10">
				<span>NOT OK</span>		  
			</td>
		</tr>
		<tr>
			<td colspan="70" rowspan="6">
				<span></span>
			</td>
			<td colspan="15">
				<span>SOFT WATER</span>		  
			</td>
			<td colspan="5">
				<span></span>		  
			</td>
			<td colspan="10">
				<span></span>		  
			</td>
		</tr>
		<tr>
			<td colspan="15">
				<span>FEED WATER</span>		  
			</td>
			<td colspan="5">
				<span></span>		  
			</td>
			<td colspan="10">
				<span></span>		  
			</td>
		</tr>
		<tr>
			<td colspan="15">
				<span>MAXTREAT DOSIND</span>		  
			</td>
			<td colspan="5">
				<span></span>		  
			</td>
			<td colspan="10">
				<span></span>		  
			</td>
		</tr>
		<tr>
			<td colspan="15">
				<span>ECONOMIX DOSING</span>		  
			</td>
			<td colspan="5">
				<span></span>		  
			</td>
			<td colspan="10">
				<span></span>		  
			</td>
		</tr>
		<tr>
			<td colspan="15">
				<span>THREMOSOL DOSING</span>		  
			</td>
			<td colspan="5">
				<span></span>		  
			</td>
			<td colspan="10">
				<span></span>		  
			</td>
		</tr>
		<tr>
			<td colspan="15">
				<span>THEMIC FLUID</span>		  
			</td>
			<td colspan="5">
				<span></span>		  
			</td>
			<td colspan="10">
				<span></span>		  
			</td>
		</tr>
		<tr>
			<td colspan="30">
				<span></span>
			</td>	
			<td colspan="10">
				<span>DATE</span>
			</td>
			<td colspan="10">
				<span>TIME</span>
			</td>
			<td colspan="20">
				<span>BUILD FOR</span>
			</td>
			<td colspan="30">
				<span></span>
			</td>
		</tr>	
		<tr>
			<td colspan="30">
				<span>CALLS RECEIVED</span>
			</td>	
			<td colspan="10">
				<span></span>
			</td>
			<td colspan="10">
				<span></span>
			</td>
			<td colspan="20">
				<span>SERVICE</span>
			</td>
			<td colspan="30">
				<span></span>
			</td>
		</tr>	
		<tr>
			<td colspan="30">
				<span>REPORTED ON/AT</span>
			</td>	
			<td colspan="10">
				<span></span>
			</td>
			<td colspan="10">
				<span></span>
			</td>
			<td colspan="20">
				<span>TRANSPORT</span>
			</td>
			<td colspan="30">
				<span></span>
			</td>
		</tr>	
		<tr>
			<td colspan="30">
				<span>COMPLETED ON/AT</span>
			</td>	
			<td colspan="10">
				<span></span>
			</td>
			<td colspan="10">
				<span></span>
			</td>
			<td colspan="20">
				<span>SPARES</span>
			</td>
			<td colspan="30">
				<span></span>
			</td>
		</tr>	
		<tr>
			<td colspan="30">
				<span>NO OF DAYS CHARGEBLE</span>
			</td>	
			<td colspan="10">
				<span></span>
			</td>
			<td colspan="10">
				<span></span>
			</td>
			<td colspan="20">
				<span>TOTAL</span>
			</td>
			<td colspan="30">
				<span></span>
			</td>
		</tr>
	</table>
</body>
</html>		
