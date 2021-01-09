pipeline {
       agent any
       stages {
           stage('restore') {
               steps {
                   bat 'dotnet restore --configfile NuGet.Config'
               }
           }
           stage('build') {
               steps {
                   bat 'dotnet build'
               }
           }
           stage('test') {
               steps {
                 bat 'dotnet test'
               }
           }
       }
}