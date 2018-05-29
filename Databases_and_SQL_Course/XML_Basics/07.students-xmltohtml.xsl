<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="students">
  <html>
  <body>
  <h1>Students</h1>
  <table>
    <tr>
      <th>Name</th>
      <th>Sex</th>
      <th>Birthdate</th>
      <th>Phone</th>
      <th>E-mail</th>
      <th>Course</th>
      <th>Specialty</th>
      <th>Faculty number</th>
    </tr>
    <xsl:for-each select="student">
        <tr>
          <td><xsl:value-of select="name"/></td>
          <td><xsl:value-of select="sex"/></td>
          <td><xsl:value-of select="birthdate"/></td>
          <td><xsl:value-of select="phone"/></td>
          <td><xsl:value-of select="email"/></td>
          <td><xsl:value-of select="course"/></td>
          <td><xsl:value-of select="specialty"/></td>
          <td><xsl:value-of select="facultynumber"/></td>
        </tr>
  	</xsl:for-each>
  </table>
  </body>
  </html>
</xsl:template>
</xsl:stylesheet>
