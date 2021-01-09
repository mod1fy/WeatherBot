pipeline {
       agent any
       stages {
           stage('restore') {
               steps {
                   sh 'dotnet restore --configfile NuGet.Config'
               }
           }
       }
}