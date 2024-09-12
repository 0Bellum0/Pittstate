import 'package:flutter/material.dart';

class GradientContainer extends StatelessWidget{
  const GradientContainer({super.Key});

  @override
  Widget build(context){
    return Container(
      decoration: const BoxDecoration(
            gradient: LinearGradient(
              colors:[
                Color.fromARGB(255, 60, 16, 162),
                Color.fromARGB(255, 40, 4, 91),
              ],
              begin: Alignment.topLeft,
              end: Alignment.bottomRight,
            ),
          ),
          child: const Center(
            child: Text("My first flutter app", style: TextStyle(
              color: Colors.white,
              fontSize: 28,),
            ),
          ),
    );
  }
}