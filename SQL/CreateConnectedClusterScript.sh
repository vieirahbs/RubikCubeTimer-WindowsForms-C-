# Este script cria um recurso do Azure Arc para conectar um cluster do Kubernetes ao Azure
# Documentação: https://aka.ms/AzureArcK8sDocs

# Faça logon no Azure
az login

# Definir assinatura do Azure
az account set --subscription f5b2dd62-6eca-4cd8-907e-40c465c22bb6

# Criar cluster conectado
az connectedk8s connect --name ClusterRubikCubeTimer --resource-group RUBIKCUBE-TIMER --location eastus --tags Datacenter=RubikCube City=São Paulo StateOrDistrict=SP CountryOrRegion=Brasil RubikCubeTimer=RUBIKCUBE-TIMER    
