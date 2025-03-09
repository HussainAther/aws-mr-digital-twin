import json
import boto3

dynamodb = boto3.resource('dynamodb')
table = dynamodb.Table('IoT_Sensor_Data')  # Ensure you have this table in DynamoDB

def lambda_handler(event, context):
    response = table.scan()  # Fetch all sensor data (can be optimized)
    return {
        "statusCode": 200,
        "headers": {
            "Content-Type": "application/json",
            "Access-Control-Allow-Origin": "*"  # Allow Unity to fetch this
        },
        "body": json.dumps(response['Items'])
    }

