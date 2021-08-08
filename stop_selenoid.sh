if [[ "$OSTYPE" == "darwin"* ]]; then
        # Mac OSX
        chmod +x cm_darwin_amd64
        ./cm_darwin_amd64 selenoid stop
        ./cm_darwin_amd64 selenoid-ui stop
elif [[ "$OSTYPE" == "win32" ]]; then
        ./ccm_windows_amd64.exe selenoid stop
        ./cm_windows_amd64.exe selenoid-ui stop
fi