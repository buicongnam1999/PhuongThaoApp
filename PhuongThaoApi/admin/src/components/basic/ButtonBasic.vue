<template>
    <div class="button">
        <slot name="img" class="img"></slot>
        <slot></slot>
    </div>
</template>
<script>
export default {
    
}
</script>
<style scoped>
.button{
    background: #019160;
    height: 40px;
    color: #fff;
    padding:0px 16px;
    text-align: center;
    font-size: 13px;
    border-radius: 4px;
    cursor: pointer;
    line-height: 40px;
}

.button:hover{
    background: #2FBE8E;
}
</style>