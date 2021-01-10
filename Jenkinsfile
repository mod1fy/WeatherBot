pipeline {
       agent any
       stages {
           stage('Checkout') {
               steps {
                   git url: 'https://github.com/mod1fy/WeatherBot', branch: 'main'
               }
           }
           stage('build') {
               steps {
                   bat 'dir'
                   bat 'dotnet build .\\src\\WeatherBot.Api\\WeatherBot.Api.csproj"'
               }
           }
           stage('test') {
               steps {
                 bat 'dotnet test'
               }
           }
       }
}