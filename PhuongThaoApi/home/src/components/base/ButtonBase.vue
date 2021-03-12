<template>
    <div class="button-basic">
        <i class="fa fa-plus" aria-hidden="true"></i><slot></slot>
    </div>
</template>
<script>
export default {
    
}
</script>
<style scoped>
.button-basic{
    border: 2px solid #e0e0e0;
    width: 180px;
    height: 60px;
    cursor: pointer;
    font-size: 20px;
    line-height: 60px;
    padding: 0 20px;
}
.button-basic:hover{
    background: red;
    opacity: 0.8;
}
.button-basic i{
    font-size: 15px;
    margin-right: 10px;
}
</style>