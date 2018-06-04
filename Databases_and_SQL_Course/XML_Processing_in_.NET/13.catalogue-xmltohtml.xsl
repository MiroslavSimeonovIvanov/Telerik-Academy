<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
    <body>
    <h2>Music catalogue</h2>
    <table border="1">
      <tr bgcolor="#96AAC2">
        <th align="left">Name</th>
        <th align="left">Artist</th>
      </tr>
      <xsl:for-each select="catalogue/album">
          <tr>
            <td><xsl:value-of select="name"/></td>
            <td><xsl:value-of select="artist"/></td>
          </tr>
    	</xsl:for-each>
    </table>
    </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
