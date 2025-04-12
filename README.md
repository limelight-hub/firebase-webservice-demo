# Register-LoginDemo

A user registration and login application with email confirmation.

## Security Setup

This application requires Firebase and Google OAuth credentials that should not be stored in the repository.

### Setting Up Firebase Credentials

1. Download your Firebase service account key from the Firebase Console
2. Store the service account key in one of these locations:
   - Set the environment variable `FIREBASE_CREDENTIALS_PATH` pointing to the JSON file
   - OR place the file at `%APPDATA%\RegisterLoginDemo\firebase-credentials.json`

### Setting Up Google OAuth Credentials

1. Download your Google OAuth client credentials from the Google Cloud Console
2. Store the credentials file in one of these locations:
   - Set the environment variable `GOOGLE_OAUTH_CREDENTIALS_PATH` pointing to the JSON file
   - OR place the file at `%APPDATA%\RegisterLoginDemo\google-oauth-credentials.json`

## Development

Make sure you have your credentials set up before running the application.

## Important Note

Never commit credential files to the repository! The `.gitignore` file is configured to exclude common credential file patterns.
