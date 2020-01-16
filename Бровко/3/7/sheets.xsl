<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version='1.0'>
	<xsl:template match="/">
		<html>
			<body>
				<h1 STYLE="font-weigth:540">My Favorite People</h1>
				<xsl:apply-templates select="PEOPLE/Main/PERSON"/>
			</body>
		</html>
	</xsl:template>
	<xsl:template match="PEOPLE/Main/PERSON">
		<html>
			<body>
				<span>Title:</span>
				<xsl:value-of select="PersonId"/>
				<br/>
				<span>Name:</span>
				<xsl:value-of select="Name"/>
				<br/>
				<br/>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet> 