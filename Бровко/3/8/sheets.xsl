<?xml version="1.0"?>

<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version='1.0'>

	<xsl:template match="/">
		<html>
			<body>
				<h1 style="font-weight:540">My University</h1>
				<table>
					<tr>
						<td style="border:1px solid grey">Class(Аудитория)</td>
						<td style="border:1px solid grey">Noofstudents(Кол-во студентов)</td>
						<td style="border:1px solid grey">Noofpresent(Кол-во присутствующих)</td>
						<td style="border:1px solid grey">Noofsections(Кол-во групп)</td>
					</tr>
					<xsl:apply-templates select="Classes/Class"/>
				</table>
			</body>
		</html>
	</xsl:template>

	<xsl:template match='Classes/Class'>
		<tr>
			<xsl:if test="@value = 1">
				<td style="border:1px solid grey"><xsl:value-of select="@value"/><span>st</span></td>
			</xsl:if>
			<xsl:if test="@value = 2">
				<td style ="border:1px solid grey"><xsl:value-of select="@value"/><span>nd</span></td>
			</xsl:if>
			<xsl:if test="@value = 3">
				<td style ="border:1px solid grey"><xsl:value-of select="@value"/><span>rd</span></td>
			</xsl:if>
			<xsl:if test="@value > 3">
				<td style ="border:1px solid grey"><xsl:value-of select="@value"/><span>th</span></td>
			</xsl:if>
			<td style ="border:1px solid grey"><xsl:value-of select="No_of_Students"/></td>
			<td style ="border:1px solid grey"><xsl:value-of select="No_of_Present"/></td>
			<td style ="border:1px solid grey"><xsl:value-of select="No_of_Section"/></td>
		</tr>

	</xsl:template>

</xsl:stylesheet> 

