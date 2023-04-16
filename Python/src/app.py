from flask import Flask, request,Blueprint, jsonify
from flask_pymongo import PyMongo

app = Flask(__name__)
app.config['MONGO_URI']= 'mongodb://localhost/pythonmongodb' #Cambiar nombre de base de datos

mongo = PyMongo(app)

@app.route('/api/v1/score', methods=['POST'])
def create_score():
    username = request.json['username']
    score = request.json['score']

    if not username or not score or not isinstance(score, int):
        return {"message": "Username or score were invalid"}, 400

    try:
        user = mongo.db.scores.find_one({"username": username})
        if user:
         return {"message": "There is user with the same name"}, 409
        mongo.db.scores.insert_one({'username': username, 'score': score})
    except Exception as e:
        return {"message": "An unexpected error has ocurred"}, 500

    return {"message": "Your score was created successfully"}, 201


@app.route('/api/v1/score', methods=['PUT'])
def update_score():
    username = request.json['username']
    score = request.json['score']

    if not username or not score or not isinstance(score, int):
        return {"message": "Username or score were invalid"}, 400

    try:
      resultado = mongo.db.scores.update_one({'username': username},  {'$set':{'username': username, 'score': score}})
      if resultado.matched_count == 0:
          return {"message": "The user doesn't exist"}, 404
        
    except Exception as e:
        return {"message": "An unexpected error has ocurred"}, 500

    return {"message": "Your score was updated successfully"}, 201

@app.route("/api/v1/scores", methods=["GET"])
def get_scores():
    page = int(request.args.get('page', 1))
    limit = int(request.args.get('limit', 5))

    scores = []

    try:
       cursor = mongo.db.scores.find().skip((page-1)*limit).limit(limit)  
       for document in cursor:
           document['_id'] = str(document['_id'])
           scores.append(document)
        
       print(scores)
    except Exception as e:

        return {"message": "An unexpected error has ocurred"}, 500
    return jsonify(scores)


if __name__ == "__main__":
    app.run(debug=True)