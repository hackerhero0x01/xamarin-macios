# Macios CI pwsh scripts.

The macios contains several pwsh modules. This makes it easy to organize code based on the type of cmdlets it provides.
Along with each module, there is a Test script that contains the pester tests for the cmdlets. To make things easier in yaml
all the modules can be imported using a pwsh manifest, which is found at MaciosCI.psd1 

The MaciosCI.psd1 manifest is autogenerated using the script CreateManifest.ps1 as follows:
```bash
CreateManifest.ps1 -ManifestPath "/output/path.psd1"
```

The manifest only needs to be recreated when you add a new module that you want to be able to import in yaml.
