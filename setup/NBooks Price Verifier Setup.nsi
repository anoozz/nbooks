!include "MUI2.nsh"
!define PRODUCT_NAME "NBooks Cash Register"
!define PRODUCT_VERSION "0.1.0.1"

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "${PRODUCT_NAME}_${PRODUCT_VERSION}_Setup.exe"

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

Section "${PRODUCT_NAME}" SecDummy

	SetOutPath "$INSTDIR\bin"  
	File "bin\cregister.exe"
	File "bin\cregister.exe.config"
	File "bin\NBooks.Core.dll"
	File "lib\Castle.DynamicProxy.dll"
	File "lib\Iesi.Collections.dll"
	File "lib\log4net.dll"
	File "lib\MySql.Data.dll"
	File "lib\NHibernate.dll"
	File "lib\System.Data.SQLite.dll"
	
	CreateDirectory "$SMPROGRAMS\${PRODUCT_NAME}"
	CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_NAME} ${PRODUCT_VERSION}.lnk" "$INSTDIR\bin\cregister.exe"
	CreateShortCut "$DESKTOP\${PRODUCT_NAME} ${PRODUCT_VERSION}.lnk" "$INSTDIR\bin\cregister.exe"

	SetOutPath "$INSTDIR"
	File "lgpl-3.0.txt"
	File "readme.txt"
	
	WriteRegStr HKCU "Software\${PRODUCT_NAME}" "" $INSTDIR
	
	WriteUninstaller "$INSTDIR\Uninstall.exe"
	SetOutPath "$INSTDIR\bin"
	CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk" "$INSTDIR\Uninstall.exe"

SectionEnd

!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
	!insertmacro MUI_DESCRIPTION_TEXT ${SecDummy} "NBooks Cash Register"
!insertmacro MUI_FUNCTION_DESCRIPTION_END

Section "Uninstall"

	Delete "$INSTDIR\Uninstall.exe"
	Delete "$INSTDIR\bin\cregister.exe"
	Delete "$INSTDIR\bin\cregister.exe.config"
	Delete "$INSTDIR\bin\NBooks.Core.dll"
	Delete "$INSTDIR\bin\Castle.DynamicProxy.dll"
	Delete "$INSTDIR\bin\Iesi.Collections.dll"
	Delete "$INSTDIR\bin\log4net.dll"
	Delete "$INSTDIR\bin\MySql.Data.dll"
	Delete "$INSTDIR\bin\NHibernate.dll"
	Delete "$INSTDIR\bin\System.Data.SQLite.dll"

	Delete "$INSTDIR\lgpl-3.0.txt"
	Delete "$INSTDIR\readme.txt"

	RMDir "$INSTDIR\bin"
	RMDir "$INSTDIR\doc"
	RMDir "$INSTDIR"

	Delete "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_NAME}.lnk"
	Delete "$SMPROGRAMS\${PRODUCT_NAME} ${PRODUCT_VERSION}\Uninstall.lnk"
	RMDir "$SMPROGRAMS\${PRODUCT_NAME}"
	Delete "$DESKTOP\${PRODUCT_NAME} ${PRODUCT_VERSION}.lnk"

	DeleteRegKey /ifempty HKCU "Software\${PRODUCT_NAME}"

SectionEnd