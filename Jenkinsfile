pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                sh 'echo "Building..."'
                sh 'dotnet build test-project.csproj'
            }
        }
        stage('Test') {
            steps {
                sh 'echo Test'
                sh 'echo add tests in the future'
            }
        }
    }    
}