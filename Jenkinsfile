pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                sh 'echo "Building..."'
                sh 'dotnet build test-project.csproj'
                sh 'echo "done building"'
            }
        }
        stage('Test') {
            steps {
                sh 'echo Test'
            }
        }
    }    
}