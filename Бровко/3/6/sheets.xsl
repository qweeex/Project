<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version='1.0'>

	<xsl:template match="/">
		<html>
			<body>
				<h1 style="font-weigth:540">My Favorite People</h1>
				<table style="width:100wh; border-spacing: 0px;" >
					<tr>
						<td style="border:1px solid">PersonId</td>
						<td style="border:1px solid">Name</td>
						<td style="border:1px solid">Address</td>
						<td style="border:1px solid">Telephone</td>
						<td style="border:1px solid">Fax</td>
						<td style="border:1px solid">E-Mail</td>
					</tr>
					<xsl:for-each select="PEOPLE/Main/PERSON">
						<xsl:sort select="Name" order="ascending"/>
						<tr>
							<td style="border:1px solid"><xsl:value-of select="PersonId"/></td>
							<td style="border:1px solid"><xsl:value-of select="Name"/></td>
							<td style="border:1px solid"><xsl:value-of select="Address"/></td>
							<td style="border:1px solid"><xsl:value-of select="Telephone"/></td>
							<td style="border:1px solid"><xsl:value-of select="Fax"/></td>
							<td style="border:1px solid"><xsl:value-of select="E-Mail"/></td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>

</xsl:stylesheet> 
