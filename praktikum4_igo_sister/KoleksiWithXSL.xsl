<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <title>Koleksi Film</title>
      </head>
      <body style="font-family:Arial, sans-serif; font-size:12pt; background-color:#f4f4f4; margin:20px;">
        <h2 style="color:teal;">Daftar Koleksi Film</h2>
        
        <xsl:for-each select="Koleksi/Film">
          <div style="background-color:teal; color:white; padding:10px; font-weight:bold; border-radius:5px 5px 0 0;">
            <xsl:value-of select="Judul"/>
          </div>
          
          <div style="background-color:white; padding:15px; margin-bottom:20px; border:1px solid #ccc; border-top:none; font-size:10pt; color:#333;">
            <p style="margin: 5px 0;"><strong>Sutradara:</strong> <xsl:value-of select="Sutradara"/></p>
            <p style="margin: 5px 0;"><strong>Genre:</strong> <xsl:value-of select="Genre"/></p>
            <p style="margin: 5px 0;"><strong>Pemain:</strong> 
              <xsl:value-of select="Pemain1"/>, 
              <xsl:value-of select="Pemain2"/>, 
              <xsl:value-of select="Pemain3"/>
            </p>
            <p style="margin: 5px 0;"><strong>Review:</strong> <xsl:value-of select="Review"/></p>
            <p style="margin: 5px 0; color:black; font-weight:bold;">Studio: <xsl:value-of select="Studio"/></p>
          </div>
        </xsl:for-each>
        
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>