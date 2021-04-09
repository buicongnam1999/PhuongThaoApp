<template>
    <div class="title">
        <div class="title-header">
            <b>{{title}}</b>
        </div>
        <div class="title-content">
            {{content}}
        </div>
        <div class="title-bottom">
            <div class="border-bottom">
                .......................................................
            </div>
            <i class="fa fa-envira" aria-hidden="true"></i>
            <div class="border-bottom">
                .......................................................
            </div>
        </div>
    </div>
</template>
<script>
export default {
    props:["title","content"],

}
</script>
<style scoped>
.title{
    margin-top: 80px;
}
.title-header{
    font-size: 35px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
    text-align: center;
}
.title-content{
    margin-top: 15px;
    text-align: center;
}
.title-bottom{
    display: flex;
    margin: 35px auto;
    width: 34%;
}
.border-bottom{
    opacity: 0.4;
    font-size: 15px;
}
.title-bottom i{
   color: red;
   opacity: 0.7;
   font-size: 30px;
   padding: 0px 20px;
}
</style>