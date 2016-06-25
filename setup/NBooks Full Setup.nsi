
!include "MUI2.nsh"
!define PRODUCT_NAME "NBooks"
!define PRODUCT_VERSION "0.1.0.3"

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "${PRODUCT_NAME}_${PRODUCT_VERSION}_FullSetup.exe"

InstallDir "$PROGRAMFILES\${PRODUCT_NAME}"

InstallDirRegKey HKCU "Software\${PRODUCT_NAME}" ""

RequestExecutionLevel user

!define MUI_ABORTWARNING

!insertmacro MUI_PAGE_LICENSE "lgpl-3.0.txt"
!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES

!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

!insertmacro MUI_LANGUAGE "English"

Section "${PRODUCT_NAME}" Section01

	SetOutPath "$INSTDIR\bin"  
	File "bin\Release\nbooks.exe"
	File "lib\Castle.DynamicProxy.dll"
	File "lib\CrystalDecisions.CrystalReports.Engine.dll"
	File "lib\CrystalDecisions.Enterprise.Framework.dll"
	File "lib\CrystalDecisions.Enterprise.InfoStore.dll"
	File "lib\CrystalDecisions.ReportSource.dll"
	File "lib\CrystalDecisions.Shared.dll"
	File "lib\CrystalDecisions.Windows.Forms.dll"
	File "lib\Iesi.Collections.dll"
	File "lib\log4net.dll"
	File "lib\MySql.Data.dll"
	File "lib\NHibernate.dll"
	File "lib\System.Data.SQLite.dll"
	File "bin\Release\NBooks.Core.dll"
	File "bin\Release\NBooks.Reports.dll"
	File "bin\Release\nbooks.exe.config"

	SetOutPath "$INSTDIR\data\sqlite"
	File "data\sqlite\Bogetz Global Solutions.sqlite"
	File "data\sqlite\E1 Prime Savers.sqlite"
	File "data\sqlite\Oporto's Dental Clinic.sqlite"
	File "data\sqlite\PG Forwarding Services.sqlite"
	File "data\sqlite\Rykamon Marketing.sqlite"

	SetOutPath "$INSTDIR\doc"
	;File "doc\home.html"
	File "doc\User Guide.pdf"
	File "doc\style.css"

	SetOutPath "$INSTDIR\doc\images"  
	File "doc\images\home.gif"
	
	SetOutPath "$INSTDIR\bin"
	
	CreateDirectory "$SMPROGRAMS\${PRODUCT_NAME}"
	CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_NAME}.lnk" "$INSTDIR\bin\nbooks.exe"
	CreateShortCut "$DESKTOP\${PRODUCT_NAME}.lnk" "$INSTDIR\bin\nbooks.exe"

	SetOutPath "$INSTDIR"
	File "lgpl-3.0.txt"
	File "readme.txt"
	
	WriteRegStr HKCU "Software\${PRODUCT_NAME}" "" $INSTDIR
	
	WriteUninstaller "$INSTDIR\Uninstall.exe"
	SetOutPath "$INSTDIR\bin"
	CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk" "$INSTDIR\Uninstall.exe"

SectionEnd

Section "Crystal Reports Runtime" SEC02  

	DetailPrint '..Installing Crystal Reports Runtime'
	SetOutPath '$TEMP'
	SetOverwrite on
	File "vendors\CRRedist2008_x86.msi" 
	ExecWait 'MsiExec.exe /q /i $TEMP\CRRedist2008_x86.msi' $0
	DetailPrint '..Crystal Reports Runtime exit code = $0'
	Delete '$TEMP\CRRedist2008_x86.msi'

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
	Delete "$INSTDIR\bin\NBooks.Core.dll"
	Delete "$INSTDIR\bin\NBooks.Reports.dll"
	Delete "$INSTDIR\bin\nbooks.exe.config"
	Delete "$INSTDIR\bin\log.txt"
	
	Delete "$INSTDIR\data\sqlite\Bogetz Global Solutions.sqlite"
	Delete "$INSTDIR\data\sqlite\E1 Prime Savers.sqlite"
	Delete "$INSTDIR\data\sqlite\Oporto's Dental Clinic.sqlite"
	Delete "$INSTDIR\data\sqlite\PG Forwarding Services.sqlite"
	Delete "$INSTDIR\data\sqlite\Rykamon Marketing.sqlite"
	
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