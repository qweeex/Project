<?xml version="1.0"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="/">
		<h1 STYLE="font-weigth:540">My Favorite People</h1>
		<table style="width:100%; border-spacing: 0px;" >
			<tr>
				<th style="border:1px solid">PersonId</th>
				<th style="border:1px solid">Name</th>
				<th style="border:1px solid">Address</th>
				<th style="border:1px solid">Telephone</th>
				<th style="border:1px solid">Fax</th>
				<th style="border:1px solid">E-Mail</th>
			</tr>
			<xsl:for-each select="PEOPLE/Main/PERSON">
				<tr>
					<td STYLE="border:1px solid"><xsl:value-of select="PersonId"/></td>
					<td STYLE="border:1px solid"><xsl:value-of select="Name"/></td>
					<td STYLE="border:1px solid"><xsl:value-of select="Address"/></td>
					<td STYLE="border:1px solid"><xsl:value-of select="Telephone"/></td>
					<td STYLE="border:1px solid"><xsl:value-of select="Fax"/></td>
					<td STYLE="border:1px solid"><xsl:value-of select="E-Mail"/></td>
				</tr>
			</xsl:for-each>
		</table>
	</xsl:template>

</xsl:stylesheet>