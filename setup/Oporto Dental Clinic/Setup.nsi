
!include "MUI2.nsh"
!define PRODUCT_NAME "NBooks"
!define PRODUCT_VERSION "0.1.0.5"

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "${PRODUCT_NAME}_${PRODUCT_VERSION}_Setup.exe"

InstallDir "$PROGRAMFILES\${PRODUCT_NAME}"

InstallDirRegKey HKCU "Software\${PRODUCT_NAME}" ""

RequestExecutionLevel user

!define MUI_ABORTWARNING

!insertmacro MUI_PAGE_LICENSE "..\..\lgpl-3.0.txt"
!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES

!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

!insertmacro MUI_LANGUAGE "English"

Section "${PRODUCT_NAME}" Section01

	SetOutPath "$INSTDIR\bin"  
	File "..\..\bin\Release\nbooks.exe"
	File "..\..\tools\Crystal Reports\CrystalDecisions.CrystalReports.Engine.dll"
	File "..\..\tools\Crystal Reports\CrystalDecisions.Enterprise.Framework.dll"
	File "..\..\tools\Crystal Reports\CrystalDecisions.Enterprise.InfoStore.dll"
	File "..\..\tools\Crystal Reports\CrystalDecisions.ReportSource.dll"
	File "..\..\tools\Crystal Reports\CrystalDecisions.Shared.dll"
	File "..\..\tools\Crystal Reports\CrystalDecisions.Windows.Forms.dll"
	File "..\..\tools\NHibernate\Castle.DynamicProxy.dll"
	File "..\..\tools\NHibernate\Iesi.Collections.dll"
	File "..\..\tools\NHibernate\NHibernate.dll"
	File "..\..\tools\log4net\log4net.dll"
	File "..\..\tools\MySql\MySql.Data.dll"
	File "..\..\tools\SQLite\System.Data.SQLite.dll"
	File "..\..\bin\Release\NBooks.Controllers.dll"
	File "..\..\bin\Release\NBooks.Core.dll"
	File "..\..\bin\Release\NBooks.Data.dll"
	File "..\..\bin\Release\NBooks.Reports.dll"
	File "..\..\bin\Release\NBooks.Services.dll"
	File "nbooks.exe.config"

	SetOutPath "$INSTDIR\data\sqlite"
	File "..\..\data\sqlite\Oporto Dental Clinic.sqlite"

	SetOutPath "$INSTDIR\doc"
	;File "..\..\doc\home.html"
	;File "..\..\doc\User Guide.pdf"
	File "..\..\doc\style.css"

	SetOutPath "$INSTDIR\doc\images"  
	File "..\..\doc\images\home.gif"
	
	SetOutPath "$INSTDIR\bin"
	
	CreateDirectory "$SMPROGRAMS\${PRODUCT_NAME}"
	CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_NAME}.lnk" "$INSTDIR\bin\nbooks.exe"
	CreateShortCut "$DESKTOP\${PRODUCT_NAME}.lnk" "$INSTDIR\bin\nbooks.exe"

	SetOutPath "$INSTDIR"
	File "..\..\lgpl-3.0.txt"
	File "..\..\readme.txt"
	
	WriteRegStr HKCU "Software\${PRODUCT_NAME}" "" $INSTDIR
	
	WriteUninstaller "$INSTDIR\Uninstall.exe"
	SetOutPath "$INSTDIR\bin"
	CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk" "$INSTDIR\Uninstall.exe"

SectionEnd

!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
	!insertmacro MUI_DESCRIPTION_TEXT ${Section01} "NBooks Accounting Application."
!insertmacro MUI_FUNCTION_DESCRIPTION_END

Section "Uninstall"

	Delete "$INSTDIR\Uninstall.exe"
	
	Delete "$INSTDIR\bin\nbooks.exe"
	Delete "$INSTDIR\bin\Castle.DynamicProxy.dll"
	Delete "$INSTDIR\bin\CrystalDecisions.CrystalReports.Engine.dll"
	Delete "$INSTDIR\bin\CrystalDecisions.Enterprise.Framework.dll"
	Delete "$INSTDIR\bin\CrystalDecisions.Enterprise.InfoStore.dll"
	Delete "$INSTDIR\bin\CrystalDecisions.ReportSource.dll"
	Delete "$INSTDIR\bin\CrystalDecisions.Shared.dll"
	Delete "$INSTDIR\bin\CrystalDecisions.Windows.Forms.dll"
	Delete "$INSTDIR\bin\Iesi.Collections.dll"
	Delete "$INSTDIR\bin\log4net.dll"
	Delete "$INSTDIR\bin\MySql.Data.dll"
	Delete "$INSTDIR\bin\NHibernate.dll"
	Delete "$INSTDIR\bin\System.Data.SQLite.dll"
	Delete "$INSTDIR\bin\NBooks.Controllers.dll"
	Delete "$INSTDIR\bin\NBooks.Core.dll"
	Delete "$INSTDIR\bin\NBooks.Data.dll"
	Delete "$INSTDIR\bin\NBooks.Reports.dll"
	Delete "$INSTDIR\bin\NBooks.Services.dll"
	Delete "$INSTDIR\bin\nbooks.exe.config"
	Delete "$INSTDIR\bin\log.txt"
	
	Delete "$INSTDIR\data\sqlite\Oporto Dental Clinic.sqlite"
	
	Delete "$INSTDIR\doc\User Guide.pdf"
	Delete "$INSTDIR\doc\home.html"
	Delete "$INSTDIR\doc\style.css"
	Delete "$INSTDIR\doc\images\home.gif"

	Delete "$INSTDIR\lgpl-3.0.txt"
	Delete "$INSTDIR\readme.txt"

	RMDir "$INSTDIR\bin"
	RMDir "$INSTDIR\data\sqlite"
	RMDir "$INSTDIR\data"
	RMDir "$INSTDIR\doc\images"
	RMDir "$INSTDIR\doc"
	RMDir "$INSTDIR"

	Delete "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_NAME}.lnk"
	Delete "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk"
	RMDir "$SMPROGRAMS\${PRODUCT_NAME}"
	Delete "$DESKTOP\${PRODUCT_NAME}.lnk"

	DeleteRegKey /ifempty HKCU "Software\${PRODUCT_NAME}"

SectionEnd