if [[ "$OSTYPE" == "darwin"* ]]; then
        # Mac OSX
        chmod +x cm_darwin_amd64
        ./cm_darwin_amd64 selenoid start --vnc
        ./cm_darwin_amd64 selenoid-ui start
elif [[ "$OSTYPE" == "win32" ]]; then
        ./ccm_windows_amd64.exe selenoid start --vnc
        ./cm_windows_amd64.exe selenoid-ui start
fi
